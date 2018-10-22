@Echo Off
for /F %%A In ('Date /T') do (
        for /F %%B In ('Time /T') Do Echo %%A %%B>date_time.txt
)

SetLocal EnableDelayedExpansion
set /a c=0
for /f "UseBackQ Delims=" %%A IN ("date_time.txt") do (
  set /a c+=1
  set "str=%%A"
  set "str_date__iz_file=%%A"
)

set str_date__iz_file=%str_date__iz_file:~0,-5%
@rem echo.%str_date__iz_file%


set str=%str:~11,-3%
@rem echo.%str%
@rem echo.%str:~0,-1%
@rem echo.%str:~1%

if %str:~0,-1% EQU 0 (
   if %str:~1% EQU 0 (
   @rem if 12 or 00
       set "str=12"
  ))

for /L %%i in (1,1,10) do (
@rem echo.%str%
if %str% LSS 12 echo.%str_date__iz_file%

if %str% GEQ 12 (
   copy /y date_time.txt date_time.bak
   for /F %%A In ('Date /T') do (
        for /F %%B In ('Time /T') do Echo %%A %%B>>date_time.txt
)
)
)
