---Library---
---Москалев Кирилл Егорович---
Для стабильной работы веб-приложения "Library" необходимо:
1. Для запуска рекомендуется сказачать Visual Studio 2015+ или Windows Server
2. .Net Framework 4.7 - https://www.microsoft.com/ru-RU/download/details.aspx?id=55167
3. Для работы с базой данных можно использовать MS SQL Server или SQL Server Express 2014+
	MS SQL Server - устанавливается как компонент для Visual Studio 2015 и выше
	SQL Server Express - https://www.microsoft.com/en-us/sql-server/sql-server-downloads
	Для установки SQL Server Express рекомендуется использовать инструкцию - https://docs.microsoft.com/ru-ru/sql/database-engine/install-windows/install-sql-server-from-the-installation-wizard-setup?view=sql-server-2014
4. Проверить строку подключения к базе данных для вашего SQL Server`а (Entity->App.config):
	-(localdb)\MSSQLLocalDB
	-.\SQLEXPRESS
	-(localdb)\v11.0

После установки необходимых компонентов Вы можете запустить проект с помощью Visual Studio, опубликовать его или развернуть.
Инструкция для развертывания решения - https://msdn.microsoft.com/ru-ru/library/dd483479(v=vs.100).aspx