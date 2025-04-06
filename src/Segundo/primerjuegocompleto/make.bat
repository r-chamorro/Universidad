@echo off

setlocal enabledelayedexpansion

REM si no hay argumentos, mostrar ayuda

if "%1"=="" goto help

REM Interpretar el primer argumento

if "%1"=="build" 	goto build
if "%1"=="clean" 	goto clean
if "%1"=="debug" 	goto debug
if "%1"=="run" 		goto run
if "%1"=="help" 	goto help

echo Comando no reconocido: %1
got end

:build
echo Compilando...
g++ main.cpp ./src/gameMap.cpp ./src/mapCell.cpp -o primerjuego.exe
goto end

:debug
echo Compilando en modo debug...
g++ -g main.cpp ./src/gameMap.cpp ./src/mapCell.cpp -o primerjuego_debug.exe
goto end

:run
echo Ejecutando juego...
.\primerjuego.exe
goto end

:clean
echo Limpiando archivos...
del /f primerjuego.exe >nul 2>&1
del /f primerjuego_debug.exe >nul 2>&1
goto end

:help
echo.
echo ====================MENU DE AYUDA=====================
echo build -- Compila el programa 
echo clean -- Limpia los archivos compilados
echo debug -- Compila en modo debug
echo run -- Ejecuta el programa compilado
echo help -- Muestra este menu
echo ======================================================
goto end

:end
endlocal