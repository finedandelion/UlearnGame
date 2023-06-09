# Essence of Gathering

## Об игре

**Платформа:** PC.

**Фреймворк:** Windows Forms.

**Жанр:** Clicker, Sandbox.

**Сеттинг:** Древние существа, управление природой, разработка ресурсов. 

**Арт-стиль**: 2D, Векторная графика.

**Целевая аудитория:** Casual-игроки, мужчины и женщицны, 12-35 лет. Карьеристы и исследователи.

**Референсы:** Cookie Clicker, Forager, Stardew valley.

## **Сюжет и игровой опыт**

**Сюжет:** В мире духов воцарилися хаос, возьми на себя роль отважной сущности, готовой вернуть баланс природы и добиться милости божества.

**Игровая цель:** Провести 8 ритуалов, чтобы обратиться к великой сущности.

**Игровой опыт:** Опробовать себя в роли могучей сущности, управляющей земными ресурсами: добывай сырьё, применяй его, чтобы создавать более сложные материалы и распоряжайся ими, как душе угодно!

## **Игровые механики**

### Физические

**(MVP) Случайное появление ресурсов на клетках поля** — через определенные интервалы времени на поле появляются объекты, которые игрок может добывать. Если поле заполнится полностью, ресурсы перестанут появляться.

**(MVP) Разработка сырья** — разрушение и добыча объектов посредством клика. C каждым кликом объект будет визуально разрушаться, а на экране появится шкала, показывающая состояние объекта, пока он не сломается окончательно и из него не выпадут ресурсы.

**Сражение с существами** — убийство существ посредством клика за определённое кол-во времени. При тапе по существу на клетке поля откроется дополнительное окно, в котором будет отображаться существо, его здоровье и шкала времени, за которое существо нужно победить.

**Культивирование** — использование специального игрового простанства для посадки растений, их выращивания и селекции. На клетках поля появляются растения. При сборе есть шанс, что с растений выпадет семечко, которое можно посадить в специально отведенной для этого вкладке. Окно для работы выглядит как клетчатое поле на земле, в каждую клетку которого можно посадить семечко. Растения растёт какое-то время. В это время оно может распространиться на соседние клетки или мутировать, если по соседству находится другие растения. Когда растение вырастет его можно собрать и получить ресурс.

**Рыбалка** — отдельное игровое пространство с мини-игрой, в которой можно ловить рыбу. На экране появляется водоём и удочка. Если у игрока есть наживка, в определённый момент на экране появится уведомление о том, что что-то попало на крючок. Затем появится шкала на которой будет изображена рыба, которая будет передвигаться по шкале, а также поплавок, который нужно передвигать вслед за рыбой. Если держать рыбу на поплавке определённое время, то её получится поймать, иначе – она сорвется и игрок ничего не получит.

**Строительство станций, их улучшение** — чтобы создавать новые ресурсы, игроку необходимо где-то работать. В специально отведённом игровом пространстве можно строить сооружения за определенные ресурсы, на которых создаются предметы. Эти структуры можно улучшать, чтобы производить предметы более эффективно.

**Перемещение между локациями** — в специальной вкладке игрок может сменить игровое поле. На каждом игровом поле появляются собственные индивидуальные объекты и существа. Объекты остаются на поле после перехода и продолжают появлятся на неактивных полях.

**Улучшение снаряжения** — на верстаке, используя доп. ресурсы, снаряжение можно улучшать. Это повышает бонусы даваемые снаряжением.

### Экономические

**(MVP) Подношения** — отдельное игровое пространство, в котором игрок собирает определённый набор ресурсов для подношения. После проведения ритуала игроку предлагается одно из двух благославений на выбор, дающие определённые бонусы.

**Алхимия** — отдельное игровое пространство, в котором можно преобразовывать ресурсы: вернуть часть ресурсов за созданный материал, изменить ресурс или материал на большее количество их худших аналогов и наоборот. Имеется шанс на непредвиденный результат: получить x2, x3, x5 ресурсов, получить редкий вариант предмета.

**Сбор инструментов и снаряжения** — изначально игроку доступна лишь кирка – инструмент, с помощью которого можно разрушать объекты на игровом поле. Продвигаясь по дереву улучшений он сможет разблокировать другие предметы, каждые из которых дают свои возможности и бонусы. Снаряжение можно улучшать, чтобы увеличивать бонусы.

**Бартер ресурсами с другими сущностями** — Время от времени заплутавшие сущности будут приходить к игроку, с ними можно меняться. Каждый ресурс в игре имеет очки стоимости, при равном количестве очков с обеих сторон или при большем количестве очков со стороны игрока можно произвести обмен.

**Коллекционирование предметов** — можно коллекционировать редкие культуры, виды рыб, минералы, трофеи монстров – сбор определенного количества тех или иных коллекционных предметов дают процентные бонусы к скорости добыче ресурсов, количеству выпадающего ресурса, скорости появления ресурсов, монстров, скорости роста культур, уменьшению сопротивляемости поплавка удочки, вероятностям некоторых событий и т.п.

### Ментальные

**(MVP) Планирование траектории своего развития** — так как игрок играет в песочницу, он свободен в своих действиях. Игрок сам решает какие материалы ему скрафтить в первую очередь, какое здание построить, какой навык разблокировать.

**(MVP) Выбор улучшений из дерева** — игроку доступно нелинейное дерево улучшений, которое он может прокачивать, чтобы получать новые возможности. Для приобретения одного навыка нужно одно очков навыков, которое получается с повышением уровня.

## **Игровые сущности (MVP)**

### Объекты окружения

- **Дерево** (Прочность: 10 | Опыт: 7 | Ресурсы: Древесина, Листья)
- **Камень** (Прочность: 12 | Опыт: 8 | Ресурсы: Камушек)
- **Железная руда** (Прочность: 14 | Опыт: 8 | Ресурсы: Камушек, Железная руда)
- **Золотая руда** (Прочность: 15 | Опыт: 8 | Ресурсы: Камушек, Золотая руда)
- **Угольная руда** (Прочность: 15 | Опыт: 8 | Ресурсы: Камушек, Уголь)
- **Останки** (Прочность: 22 | Опыт: 8 | Ресурсы: Кости, Эссенция) 
- **Куст** (Прочность: 6 | Опыт: 6 | Ресурсы: Волокно, ягоды, листья)
- **Цветы** (Прочность: 4 | Опыт: 4 | Ресурсы: Волокно, лепестки)
- **Песчанник** (Прочность: 18 | Опыт: 7 | Ресурсы: Камушек, песок)
- **Живое дерево** (Прочность: 20 | Опыт: 8 | Ресурсы: Древесина, волокно, листья, ягоды, эссенция)
- **Звезда** (Прочность: 1 | Опыт: 15 | Ресурсы: —)
- **Сланец** (Прочность: 30 | Опыт: 9 | Ресурсы: Камушек, уголь, железная руда, золотая руда, кристаллы)
- **Кристалл** (Прочность: 26 | Опыт: 10 | Ресурсы: Камушек, осколок кристалла)
- **Дар** (Прочность: 8 | Опыт: 7 | Ресурсы: Случайный предмет из требуемых для текущего подношения)
- **Обелиск** (Прочность: 17 | Опыт: 7 | Ресурсы: Древесина, эссенция)
- **Олень** (Прочность: 24 | Опыт: 9 | Ресурсы: Кости, мясо, кожа, эссенция)
- **Слизень** (Прочность: 20 | Опыт: 7 | Ресурсы: Слизь, эссенция)
- **Летучая мышь** (Прочность: 30 | Опыт: 9 | Ресурсы: Кожа, мясо, эссенция)

### Ресурсы

- Древесина
- Доски
- Волокно
- Листья
- Лепестки
- Ягоды
- Камушек
- Железная руда
- Золотая руда
- Уголь
- Песок
- Кости
- Эссенция
- Слизь
- Мясо
- Кожа
- Осколок кристалла

### Материалы и крафтовые предметы

- Доски
- Заострённый камень
- Инструмент
- Пыльца
- Заряженный кристалл
- Верёвка
- Твёрдая верёвка
- Ожерелье
- Ожерелье из костей
- Венок
- Миска
- Салат
- Мясное блюдо
- Кубок
- Вино
- Пустой тотем
- Наполненный тотем
- Золотой тотем
- Писание
- Священное писание

### Навыки
- **Собиратель**

  Описание: Вы восстанавливаете связь с природой. На поле появляются кусты и цветы. -1c Таймера.

- **Ремесленник**

  Описание: Владение инструментом — большое искусство. Некоторые крафты становятся проще. Вы получаете небольшой набор ресурсов.

- **Мастер I**

  Описание: Почётное звание заслуживают лишь трудом и упорством. +0.2 ко множителю опыта. Сила клика увеличивается на +1.

- **Мастер II**

  Описание: Почётное звание заслуживают лишь трудом и упорством. Увеличивает прочность предметов в 2 раза! (Не действует на существ и звёзды) +2 к количеству собираемых ресурсов. (кроме эссенций)

- **Мастер III**

  Описание: Почётное звание заслуживают лишь трудом и упорством. Некоторые крафты дают дополнительные ресурсы. -1c. Таймера. +10% шанс появления доп. объекта на поле.

- **Авантюрист**

  Описание: Новые земли ждут вас! Расширяет игровое поле на две клетки. На поле появляются руды. +1 к количеству собираемых ресурсов. (кроме эссенций)

- **Археолог**

  Описание: На поиски древних ископаемых! Расширяет игровое поле на три клетки. На поле появляются песчаник и ископаемые. +0.2 ко множителю опыта.

- **Охотник**

  Описание: Живые существа заполняют ваши просторы. На поле появляются слизни и олени.

- **Спелеолог**

  Описание: Пора исследовать глубины пещер! На поле появляются кристаллы и летучие мыши. +10% шанс появления доп. объекта на поле.

- **Исследователь**

  Описание: Не существует мест, где бы вы не бывали. Расширяет игровое поле на три клетки. -1с. Таймера. +20% шанс появления доп. объекта на поле.

- **Волшебник**

  Описание: Силы природы наполняют и усиляют вас. На поле появляются звёзды. С живых существ начинают выпадать эссенции.

- **Жрец**

  Описание: Повинуйся и славь своё божество. На поле появляются обелиски и дары. Дары содержат один случайный предмет из тех, что требует Божество. -1c. Taймера.

- **Созидатель**

  Описание: Вы познали способы владения природой. Кол-во появляемых предметов увеличено вдвое.

### Крафты

1. Доски (x2) <- Древесина (x1).
2. Заострённый камень (х1) <- Камушек (х2).
3. Инструмент (х1) <- Железная руда (х4) + Уголь (х2) + Слизь (х1).
4. Заряженный кристалл (х1) <- Осколок кристалла (х1) + Эссенция (х5).
5. Пыльца (х5) <- Эсенция (х2) + Кость (х5) + Песок(х5).
6. Миска (х1) <- Доска (х4) + Заострённый камень (х1).
7. Салат (х1) <- Миска (х1) + Ягоды (х10) + Листья (х5).
8. Мясное блюдо (х1) <- Миска (х1) + Мясо (х4) + Кость (х1).
9. Пустой тотем (х1) <- Древесина (х3) + Заострённый камень (х1).
10. Наполненный тотем (х1) <- Пустой тотем (х1) + Заряженный кристалл(х2).
11. Верёвка (х2) <- Волокно (х14) + Заострённый камень (х1).
12. Венок (х1) <- Лепестки (х15) + Волокно (х8).
13. Ожерелье (х1) <- Верёвка (х1) + Камушек (х5).
14. Твёрдая верёвка (х1) <- Верёвка (х2) + Слизь (х2) + Уголь (х1).
15. Ожерелье из костей (х1) <- Твёрдая верёвка (х1) + Кости (х10).
16. Писание (х1) <- Кожа (х5) + Заострённый камень (х1) + Уголь (х4).
17. Священное писание (х1) <- Писание (х2) + Заряженный кристалл (х1).
18. Кубок (х1) <- Золотая руда (х4) + Инструмент (х1).
19. Вино (х1) <- Кубок (х1) + Ягоды (х15) + Пыльца (х1).
20. Золотой тотем (х1) <- Золотая руда (х6) + Кристалл (х5) + Пустой тотем (х3).
21. Древесина (х1) <- Лепестки (х4) + Пыльца (х1).
22. Древесина (х1) <- Волокно (х3) + Пыльца (х1).
23. Древесина (х1) <- Камень (х3) + Пыльца (х1).
24. Волокно (х2) <- Древесина (х3) + Заострённый камень (х1) + Пыльца (х1).
25. Ягоды (х5) <- Листья (х7) + Пыльца (х1).
26. Камушек (х1) <- Древесина (х3) + Пыльца (х1).
27. Песок (х5) <- Камушек (х5) + Инструмент (х1) + Миска (х1).
28. Золотая руда (х1) <- Железная руда (х3) + Камушек (х2) + Пыльца (х1).
29. Железная руда (х1) <- Золотая руда (х3) + Камушек (х2) + Пыльца (х1).
30. Уголь (х2) <- Древесина (х3) + Уголь (х1).
31. Уголь (х1) <- Камушек (х4) + Пыльца (х1).
32. Кожа (х1) <- Мясо (х1) + Кости (х3) + Пыльца (х1).
33. Мясо (х1) <- Кожа (х1) + Кости(х3) + Пыльца (х1).
34. Салат (х1) <- Мясное блюдо (х2) + Пыльца (х1).
35. Мясное блюдо (х1) <- Салат (х3) + Пыльца (х1).

### Благославения

1. Время таймера уменьшается на 1с. | +10% шанс появления доп. объекта на поле.
2. Все существа слабеют на 5 ед. прочности | Все существа становятся сильнее на 10 ед. прочности. +1 к ресурсам от существ.
    (не распространяется на эсенции)
3. Мгновенно даёт 1 уровень. | Увеличивает множитель опыта на +0.1.
4. Увеличивает количество камня в вашем инвентаре вдвое. | Увеличивает количество древесниы в вашем инвентаре вдвое.
5. Заменяет все камни, появляемые на поле, на сланцы. | Заменяет все деревья, появялемые на поле, на живые деревья.
6. Мгновенно даёт 1 уровень. | Увеличивает множитель опыта на +0.1.
7. Время таймера уменьшается на 1с. | +10% шанс появления доп. объекта на поле.

### Подношения

1. Древесина (х8)
2. Пустой тотем (х5) + Ягоды (х15) + Венок (х3).
3. Пустой тотем (х5) + Салат (х5) + Ожерелье (х3).
4. Мясное блюдо (х3) + Салат (х3) + Пустой тотем (х10) + Ожерелье (х5).
5. Писание (х5) + Ожерелье из костей (х5) + Венок (х5) + Наполненный тотем (х5).
6. Вино (х10) + Мясное блюдо (х8) + Писание (х5) + Наполненный тотем (х10).
7. Пустой тотем (х20) + Наполненный тотем (х5) + Золотой тотем (х5) +

   Венок (х3) + Священное писание (х3) + Ожерелье из костей (х5).
9. Золотой тотем (х15) + Священное писание (х8) + Ожерелье из костей (х5) + Вино (х5).

## Ссылки

### [Figma:](https://www.figma.com/file/toGSxgZgzLSNi84n7w9ZFu/%D0%9A%D0%BE%D0%BD%D0%BA%D1%83%D1%80%D1%81-%D0%B8%D0%B3%D1%80-%D1%84%D0%B8%D0%B3%D0%BC%D0%B0?type=design&node-id=0-1&t=0UMk6srjwFCfijD0-0) Дизайн, макет интерфейса и кликабельный прототип.

