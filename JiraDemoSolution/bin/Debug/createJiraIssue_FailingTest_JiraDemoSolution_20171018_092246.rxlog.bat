@ECHO off
CD ""
CALL "" http://rxpresales006/jira/ automationuser rxtest FailingTest  RXDEM "Bug" "" "{LB} " "C:\Users\hhafner\Documents\Ranorex\RanorexStudio Projects\JiraDemoSolution\JiraDemoSolution\bin\Debug\JiraDemoSolution_20171018_092246.rxzlog" ""  %* > return_string_FailingTest.txt
type return_string_FailingTest.txt
FOR /F "tokens=2,6,8 delims== " %%I IN (return_string_FailingTest.txt) DO ( set KEY=%%I & set ID=%%J & set URL=%%K)
set ID=%ID:~0,-1%
if %errorlevel% neq 0 echo ERROR: Something went wrong uploading the issue! & pause
if %errorlevel% neq 0 exit /b %errorlevel%
echo Issue created and report uploaded
set /p answer=Do you want to open the issue in your default browser (Y/[N])?
if /i "%answer:~,1%" EQU "Y" start %URL%
else exit /b
echo Please type Y for Yes or N for No
