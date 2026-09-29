:: ============================================================================
:: BUILD NAVEGADOR - CUALQUIER VERSION DE VISUAL STUDIO / MSBUILD
:: ============================================================================
:: Compila, en una sola pasada y en el orden correcto de dependencias, todo lo
:: que necesita el Navegador:
::
::   1. CONSULTAS     : Consultas_Componentes -> Consultas_Mantenimiento -> Consultas
::   2. SEGURIDAD     : CapaModelo_Seguridad -> CapaControlador_Seguridad
::   3. NAVEGADOR     : CapaModelo -> CapaControlador -> CapaVista
::   4. SEGURIDAD VISTA : CapaVista_Seguridad (depende de CapaVista_Navegador)
::   5. EJECUTABLES   : Ejecucion_Navegador, Ejecucion_Seguridad, Ejecucion_Consultas
::
:: MSBuild se busca automaticamente (vswhere, VS 2022/2019/2017, MSBuild 14/12,
:: .NET Framework, PATH). Si no se encuentra, el script pregunta la ruta.
::
:: REPORTEADOR queda fuera a proposito (Navegador no lo usa).
::
:: Los proyectos de las capas (1 a 4) detienen el proceso al primer error.
:: Los ejecutables (5) se compilan todos y se reporta cuales fallaron.
:: ============================================================================

:INICIO
@echo off
setlocal enabledelayedexpansion
color 0A

:: ---------------------------------------------------------------------------
:: RUTA FIJA DEL REPOSITORIO (cambiar solo si el repositorio cambia)
:: ---------------------------------------------------------------------------
set "COMP=C:\proyectoasis22k26\codigo\componentes"

:: ---------------------------------------------------------------------------
:: BUSCAR MSBUILD AUTOMATICAMENTE (cualquier version instalada)
:: ---------------------------------------------------------------------------
set "MSBUILD_PATH="
set "PF86=%ProgramFiles(x86)%"
if not defined PF86 set "PF86=%ProgramFiles%"
set "PF64=%ProgramFiles%"
set "VSWHERE=%PF86%\Microsoft Visual Studio\Installer\vswhere.exe"

:: 1) vswhere (detecta VS 2017/2019/2022 y Build Tools)
if exist "%VSWHERE%" (
    for /f "usebackq delims=" %%i in (`"%VSWHERE%" -latest -prerelease -products * -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe`) do set "MSBUILD_PATH=%%i"
)

:: 2) Rutas conocidas de Visual Studio 2022 / 2019 / 2017
if not defined MSBUILD_PATH (
    for %%V in (18 2022 2019 2017) do (
        for %%E in (Enterprise Professional Community Insiders BuildTools Preview) do (
            for %%B in (Current 15.0) do (
                if not defined MSBUILD_PATH if exist "%PF64%\Microsoft Visual Studio\%%V\%%E\MSBuild\%%B\Bin\MSBuild.exe" set "MSBUILD_PATH=%PF64%\Microsoft Visual Studio\%%V\%%E\MSBuild\%%B\Bin\MSBuild.exe"
                if not defined MSBUILD_PATH if exist "%PF86%\Microsoft Visual Studio\%%V\%%E\MSBuild\%%B\Bin\MSBuild.exe" set "MSBUILD_PATH=%PF86%\Microsoft Visual Studio\%%V\%%E\MSBuild\%%B\Bin\MSBuild.exe"
            )
        )
    )
)

:: 3) MSBuild antiguo (VS 2015 / 2013) o el de .NET Framework
if not defined MSBUILD_PATH if exist "%PF86%\MSBuild\14.0\Bin\MSBuild.exe" set "MSBUILD_PATH=%PF86%\MSBuild\14.0\Bin\MSBuild.exe"
if not defined MSBUILD_PATH if exist "%PF86%\MSBuild\12.0\Bin\MSBuild.exe" set "MSBUILD_PATH=%PF86%\MSBuild\12.0\Bin\MSBuild.exe"
if not defined MSBUILD_PATH if exist "%windir%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" set "MSBUILD_PATH=%windir%\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
if not defined MSBUILD_PATH if exist "%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" set "MSBUILD_PATH=%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

:: 4) Lo que haya en el PATH
if not defined MSBUILD_PATH (
    for /f "delims=" %%i in ('where msbuild 2^>nul') do if not defined MSBUILD_PATH set "MSBUILD_PATH=%%i"
)

:: 5) Ultimo recurso: preguntar
if not defined MSBUILD_PATH (
    echo No se encontro MSBuild automaticamente.
    set /p "MSBUILD_PATH=Escribe la ruta completa de MSBuild.exe: "
)
:: Quitar comillas si el usuario las escribio
if defined MSBUILD_PATH set "MSBUILD_PATH=!MSBUILD_PATH:"=!"

:: MSBuild viejo (14.0, 12.0, .NET Framework) no soporta /restore
set "RESTORE_ARG=/restore"
echo "%MSBUILD_PATH%" | findstr /i /l /c:"v4.0.30319" /c:"14.0\Bin" /c:"12.0\Bin" >nul && set "RESTORE_ARG="

set "ROOT_DIR=%~dp0"
cd /d "%ROOT_DIR%"
if not exist "logs" mkdir logs
set "LOG=%ROOT_DIR%logs\build_navegador_log.txt"
echo ==== Build Navegador %DATE% %TIME% ==== > "%LOG%"

echo ============================================
echo COMPILACION NAVEGADOR (CONSULTAS + SEGURIDAD)
echo ============================================

if not defined MSBUILD_PATH goto ERR_MSBUILD
if not exist "%MSBUILD_PATH%" goto ERR_MSBUILD
if not exist "%COMP%" (
    echo [ERROR] No existe la carpeta de componentes:
    echo         %COMP%
    echo         Ajusta COMP al inicio de este archivo.
    goto FIN_ERROR
)

echo MSBuild: %MSBUILD_PATH%
echo MSBuild: %MSBUILD_PATH% >> "%LOG%"
if not defined RESTORE_ARG echo [AVISO] Este MSBuild no soporta /restore: los paquetes NuGet no se restauran.

set /a total=0
set /a ok=0
set /a fail=0

:: ==========================================================
:: 1) CONSULTAS
:: ==========================================================
echo.
echo ===== 1) CONSULTAS =====
call :Build "%COMP%\consultas\Consultas_Componentes\CapaModelo_Componentes\CapaModelo_Componentes.csproj" || goto RESUMEN
call :Build "%COMP%\consultas\Consultas_Componentes\CapaControlador_Componentes\CapaControlador_Componentes.csproj" || goto RESUMEN
call :Build "%COMP%\consultas\Consultas_Componentes\CapaVista_Componentes\CapaVista_Componentes.csproj" || goto RESUMEN

call :Build "%COMP%\consultas\Consultas_Mantenimiento\CapaModelo_Mantenimiento\CapaModelo_Mantenimiento.csproj" || goto RESUMEN
call :Build "%COMP%\consultas\Consultas_Mantenimiento\CapaControlador_Mantenimiento\CapaControlador_Mantenimiento.csproj" || goto RESUMEN
call :Build "%COMP%\consultas\Consultas_Mantenimiento\CapaVista_Mantenimiento\CapaVista_Mantenimiento.csproj" || goto RESUMEN

call :Build "%COMP%\consultas\Consultas\CapaModelo_Consultas\CapaModelo_Consultas.csproj" || goto RESUMEN
call :Build "%COMP%\consultas\Consultas\CapaControlador_Consultas\CapaControlador_Consultas.csproj" || goto RESUMEN
call :Build "%COMP%\consultas\Consultas\CapaVista_Consultas\CapaVista_Consultas.csproj" || goto RESUMEN

:: ==========================================================
:: 2) SEGURIDAD (capas que NO dependen del Navegador)
:: ==========================================================
echo.
echo ===== 2) SEGURIDAD: MODELO Y CONTROLADOR =====
call :Build "%COMP%\seguridad\Seguridad\CapaModelo_Seguridad\CapaModelo_Seguridad.csproj" || goto RESUMEN
call :Build "%COMP%\seguridad\Seguridad\CapaControlador_Seguridad\CapaControlador_Seguridad.csproj" || goto RESUMEN

:: ==========================================================
:: 3) NAVEGADOR
:: ==========================================================
echo.
echo ===== 3) NAVEGADOR =====
call :Build "%COMP%\navegador\Navegador\CapaModelo_Navegador\CapaModelo_Navegador.csproj" || goto RESUMEN
call :Build "%COMP%\navegador\Navegador\CapaControlador_Navegador\CapaControlador_Navegador.csproj" || goto RESUMEN
call :Build "%COMP%\navegador\Navegador\CapaVista_Navegador\CapaVista_Navegador.csproj" || goto RESUMEN

:: ==========================================================
:: 4) SEGURIDAD VISTA (usa el control Navegador, por eso va despues)
:: ==========================================================
echo.
echo ===== 4) SEGURIDAD: VISTA =====
call :Build "%COMP%\seguridad\Seguridad\CapaVista_Seguridad\CapaVista_Seguridad.csproj" || goto RESUMEN

:: ==========================================================
:: 5) EJECUTABLES (no detienen el proceso si fallan)
:: ==========================================================
echo.
echo ===== 5) EJECUTABLES =====
call :Build "%COMP%\navegador\Ejecucion_Navegador\Ejecucion_Navegador.sln"
call :Build "%COMP%\seguridad\Ejecucion_Seguridad\Ejecucion_Seguridad.sln"
call :Build "%COMP%\consultas\Ejecucion_Consultas\Ejecucion_Consultas.sln"

:RESUMEN
echo.
echo ============================================
echo RESUMEN
echo Total: %total%   Correctos: %ok%   Errores: %fail%
echo Log completo: %LOG%
echo ============================================

:: ==========================================================
:: VERIFICAR DLL / EXE GENERADOS
:: ==========================================================
echo.
echo ===== VERIFICANDO SALIDAS =====
set "SALIDAS="
set "SALIDAS=%SALIDAS% consultas\Consultas_Componentes\CapaVista_Componentes\bin\Debug\CapaVista_Componentes.dll"
set "SALIDAS=%SALIDAS% consultas\Consultas_Mantenimiento\CapaVista_Mantenimiento\bin\Debug\CapaVista_Mantenimiento.dll"
set "SALIDAS=%SALIDAS% consultas\Consultas\CapaVista_Consultas\bin\Debug\CapaVista_Consultas.dll"
set "SALIDAS=%SALIDAS% seguridad\Seguridad\CapaModelo_Seguridad\bin\Debug\CapaModelo_Seguridad.dll"
set "SALIDAS=%SALIDAS% seguridad\Seguridad\CapaControlador_Seguridad\bin\Debug\CapaControlador_Seguridad.dll"
set "SALIDAS=%SALIDAS% navegador\Navegador\CapaModelo_Navegador\bin\Debug\CapaModelo_Navegador.dll"
set "SALIDAS=%SALIDAS% navegador\Navegador\CapaControlador_Navegador\bin\Debug\CapaControlador_Navegador.dll"
set "SALIDAS=%SALIDAS% navegador\Navegador\CapaVista_Navegador\bin\Debug\CapaVista_Navegador.dll"
set "SALIDAS=%SALIDAS% seguridad\Seguridad\CapaVista_Seguridad\bin\Debug\CapaVista_Seguridad.dll"
set "SALIDAS=%SALIDAS% navegador\Ejecucion_Navegador\Ejecucion_Navegador\bin\Debug\Ejecucion_Navegador.exe"
set "SALIDAS=%SALIDAS% seguridad\Ejecucion_Seguridad\Ejecucion_Seguridad\bin\Debug\Ejecucion_Seguridad.exe"
set "SALIDAS=%SALIDAS% consultas\Ejecucion_Consultas\Ejecucion_Consultas\bin\Debug\Ejecucion_Consultas.exe"

for %%s in (%SALIDAS%) do (
    if exist "%COMP%\%%s" (
        echo [OK]    %%s
    ) else (
        echo [FALTA] %%s
    )
)

echo.
echo ============================================
echo [R] Recompilar     [S] Salir
echo ============================================
choice /c RS /n /m "Seleccion: "
if errorlevel 2 goto FIN
if errorlevel 1 goto INICIO

:ERR_MSBUILD
echo [ERROR] No se encontro MSBuild.
echo         Instala "Build Tools for Visual Studio" (gratis, sin IDE)
echo         o escribe la ruta correcta cuando el script la pida.
goto FIN_ERROR

:FIN_ERROR
echo.
pause
exit /b 1

:FIN
exit /b 0


:: ==========================================================
:: FUNCION :Build  -> %1 = ruta del .csproj o .sln
:: Restaura paquetes NuGet (si el MSBuild lo soporta), recompila en Debug
:: y registra el resultado.
:: Devuelve errorlevel 0 si compilo, 1 si fallo.
:: ==========================================================
:Build
set /a total+=1
echo ------------------------------------------------
echo Compilando: %~nx1
echo ------------------------------------------------
set "TMPLOG=%ROOT_DIR%logs\_ultimo.txt"
if /i "%~x1"==".csproj" (
    "%MSBUILD_PATH%" "%~1" %RESTORE_ARG% /p:RestorePackagesConfig=true /p:SolutionDir="%~dp1..\\" /t:Rebuild /p:Configuration=Debug /v:minimal > "%TMPLOG%" 2>&1
) else (
    "%MSBUILD_PATH%" "%~1" %RESTORE_ARG% /t:Rebuild /p:Configuration=Debug /v:minimal > "%TMPLOG%" 2>&1
)
set "BUILD_RC=%errorlevel%"
echo. >> "%LOG%"
echo ##### %~1 >> "%LOG%"
type "%TMPLOG%" >> "%LOG%"
if not "%BUILD_RC%"=="0" (
    echo [ERROR] %~nx1  ^(ver log^)
    findstr /i /c:": error " /c:"error MSB" "%TMPLOG%"
    echo [ERROR] %~1 >> "%LOG%"
    set /a fail+=1
    exit /b 1
)
echo [OK] %~nx1
echo [OK] %~1 >> "%LOG%"
set /a ok+=1
exit /b 0