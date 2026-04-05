# GeometricsLibrary Wiki



## О библиотеке



\*\*GeometricsLibrary\*\* — это библиотека на C# для базовых геометрических вычислений.

Она предоставляет классы для работы с основными фигурами:



\- Circle

\- Square

\- Triangle

\- Rectangle

\- Trapezoid



Библиотека позволяет вычислять:



\- площадь

\- периметр

\- диаметр

\- диагональ

\- углы треугольника



## Возможности



\- Простая объектная модель

\- Проверка входных параметров через исключения

\- Поддержка CI

\- Наличие версий через GitHub Releases



## Состав библиотеки



### Circle

Работа с окружностью: площадь, длина окружности, диаметр.



### Square

Работа с квадратом: площадь, периметр, диагональ.



### Triangle

Работа с треугольником: площадь, периметр, углы.



### Rectangle

Работа с прямоугольником: площадь, периметр, диагональ.



### Trapezoid

Работа с трапецией: площадь и периметр.

## Установка



При установке Geometrics в тесты нужно использовать команду:

```powershell
dotnet nuget add source --username qHomee - password ghp\\\\\\\_pJ1FE2oEtOmKVvPbD4rtjazU57qfxe2xQpgF --store-password-in-clear-text -name github
https://nuget.pkg.github.com/qHomeee/index.json 

```

Далее пишем еще одну команду:
```powershell

dotnet add package qHomeee. GeometricsLibrary

```


##Использование



В любом проекте после установки: 



```C#

using Geometrics;

```



##Запуск тестов



нужно склонировать репозиторий:



https://github.com/qHomeee/GeometricsLibrary.Testing.git



открыть проект и запустить тесты





