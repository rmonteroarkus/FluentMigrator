@echo off
if "%1" == "rollback" goto rollback
if "%1" == "" goto migrate

goto error

:migrate
migrate -db SqlServer2014 -connection "Server=PROTONCANNON; Database=Organization; Persist Security Info=True; Integrated Security=True;" -assembly "Organization.dll"
goto done

:rollbak
migrate -db SqlServer2014 -connection "Server=PROTONCANNON; Database=Organization; Persist Security Info=True; Integrated Security=True;" -assembly "Organization.dll" -task rollback:all
goto done

:error
echo "No valid command"

:done
echo "Completed"