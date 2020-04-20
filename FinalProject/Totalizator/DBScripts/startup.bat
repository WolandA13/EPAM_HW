set user="TotalizatorApp"
set password="Gfccdjhlqwerty"
set server="WOLAND-A\MSSQLSERVER01"
set database="TotalizatorDB"
set currentPath=%~dp0

sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateRolesTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateUsersTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateSportsTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateSportEventsTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateBetsTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreatePersonalDataTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateContactInformationTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateResultTypesTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateResultsTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateTeamsTable.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i TablesCreationScripts\CreateSportEventTeamsTable.sql


sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Bets\DeleteBetById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Bets\InsertBet.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Bets\SelectAllBets.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Bets\SelectBetById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Bets\SelectBetByUserId.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Bets\UpdateBet.sql

sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\ContactInformation\DeleteContactInformationById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\ContactInformation\InsertContactInformation.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\ContactInformation\SelectAllContactInformation.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\ContactInformation\SelectContactInformationById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\ContactInformation\SelectContactInformationByPersonalDataId.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\ContactInformation\UpdateContactInformation.sql

sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\PersonalData\DeletePersonalDataById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\PersonalData\InsertPersonalData.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\PersonalData\SelectAllPersonalData.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\PersonalData\SelectPersonalDataById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\PersonalData\SelectPersonalDataByUserId.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\PersonalData\UpdatePersonalData.sql

sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\SportEvents\DeleteSportEventById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\SportEvents\InsertSportEvent.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\SportEvents\SelectAllSportEvents.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\SportEvents\SelectSportEventById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\SportEvents\SelectSportEventsBySportId.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\SportEvents\UpdateSportEvent.sql

sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Teams\DeleteTeamById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Teams\InsertTeam.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Teams\SelectAllTeams.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Teams\SelectTeamById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Teams\UpdateTeam.sql

sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Users\DeleteUserById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Users\InsertUser.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Users\SelectAllUsers.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Users\SelectUserById.sql
sqlcmd -S %server% -d %database% -U %user% -P %password% -i StoredProcedures\Users\UpdateUser.sql


REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InserRoles
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertUsers
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertSports
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertSportEvents
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertBets
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertPersonalData
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertContactInformation
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertResultTypes
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertResults
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertTeams
REM sqlcmd -S %server% -d %database% -U %user% -P %password% -i DataInsertScripts\InsertSportEventTeams

pause