# Содержание
1. [Диаграмма активностей](#-Диаграмма-активностей)  
1.1 [Начать игру](#11-Начать-игру)  
1.2 [Выход из игры](#12-Выход-из-игры)  
1.3 [Торговля](#13Торговля)  
1.4 [Сражение](#14Сражение)   
1.5 [Сбор предметов](#15-Сбор-предметов)  
1.6 [Выброс предметов](#16-Выброс-предметов)   
1.7 [Генерация мира](#17-Генерация-мира)  
# 1. Диаграмма активностей
## 1.1 Начать игру  

Если игрок нажимает кнопку "Play" - запускается игровой процесс.  
![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/Play.jpg)
## 1.2 Выйти из игры  

Если игрок нажимает "Exit" - игра закрывается.

![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/Exit.jpg)

## 1.3 Торговля 

Если игрок решил купить предмет, и у него хватает золота, и у него есть место в инвентаре - предмет покупается( стоимость предмета вычитается из золота игрока, а в свободную ячейку инвентаря помещатся предмет). Если игрок решил продать предмет - выбранный  предмет продаётся( исчезает из инвентаря игрока, а его стоимость прабавляется к золоту игрока). 

![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/Trade.jpg)

## 1.4 Сражение  

Если атакует игрок и его атака попадает по противнику - противнику наносится урон, если здоровье противника опускается до 0, то сражение оканчивается и игрок получает награду. Если противник атакует и его атака достигает игрока, то игроку наносится урон, если здоровье игрока опускается до 0, то сражение оканчивается и игра начмнается заново.  

![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/Battle.jpg)

## 1.5 Сбор предметов 

Если игрок находит предмет и решает его подобрать - при наличии пустых ячеек в инвентаре, предмет займёт одну из них. 

![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/Gathering.jpg)

## 1.6 Выброс предметов

Если игрок решил выбросить предмет - предмет удаляется из инвентаря.  

![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/ThrowOutItem.jpg)

## 1.7 Генерация мира

Если игрок прошёл игровой уровень - создаётся новый уровень.  

![](https://github.com/KabarykhaVictor750504/SPoH/blob/master/Diagrams/Activity/Generation.jpg)
