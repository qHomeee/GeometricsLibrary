\## Установка

При установке Geometrics в тесты нужно использовать команду:

```powershell

dotnet nuget add source --username KironIllo - password ghp\\\_pJ1FE2oEtOmKVvPbD4rtjazU57qfxe2xQpgF --store-password-in-clear-text -name github

https://nuget.pkg.github.com/qHomee/index.json 

```



Далее пишем еще одну команду:

```powershell

dotnet add package qHomeee. GeometricsLibrary

```







\##Использование

В любом проекте после установки: 

```C#

using Geometrics;

```

\##Запуск тестов

нужно склонировать репозиторий:

https://github.com/qHomeee/GeometricsLibrary.Testing.git

открыть проект и запустить тесты

