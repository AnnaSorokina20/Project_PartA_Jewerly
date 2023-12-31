# Система Управління Дорогоцінним Камінням

## Вступ
Ця система розроблена для управління ієрархією дорогоцінного та напівдорогоцінного каміння. Вона дозволяє користувачам відбирати каміння для намиста, розраховувати загальну вагу (у каратах) та вартість, сортувати каміння за вартістю, а також знаходити каміння у намисті, яке відповідає заданим параметрам кольору.

## Особливості
- Визначення ієрархії дорогоцінного та напівдорогоцінного каміння.
- Відбір каміння для складання намиста.
- Розрахунок загальної ваги та вартості намиста.
- Сортування каміння у намисті за їх вартістю.
- Пошук каміння в намисті за кольором.

## Ієрархія Класів
Система визначає абстрактні класи `Stone` та `Necklace`, з класами `PreciousStone` та `SemiPreciousStone`, які є похідними. Інтерфейс `IGemstone` забезпечує, що всі камені реалізують необхідні методи для управління своїми властивостями.

## Інформація про реалізацію
Програма розроблена на мові програмування C# і використовує об'єктно-орієнтований підхід для моделювання дорогоцінного каміння. Система включає наступні ключові класи та інтерфейси:

### Клас Stone
Це абстрактний базовий клас для всіх типів каміння, що містить основні властивості, такі як ім'я, вага в каратах, ціна та колір. Клас надає абстрактні методи для отримання цих властивостей, а також метод GetDetails() для отримання детальної інформації про камінь.

### Клас PreciousStone
Цей клас наслідується від Stone та додає додаткову властивість "чистота", яка визначає якість дорогоцінного каміння.

### Клас SemiPreciousStone
Схожий на PreciousStone, але замість чистоти, цей клас містить властивість "твердість", яка важлива для напівдорогоцінного каміння.

### Інтерфейс IGemstone
Визначає контракт для всіх дорогоцінних каменів, гарантуючи що кожен камінь буде мати методи для отримання імені, ваги, вартості та кольору.

### Клас Necklace
Використовується для створення намиста, що містить колекцію дорогоцінних каменів. Надає методи для додавання, видалення, пошуку та сортування каменів, а також методи для обчислення загальної ваги та вартості намиста.

### Інші класи та методи
Програма також містить допоміжні класи та методи для роботи з камінням, такі як методи для сортування каміння за вартістю, пошуку за кольором, та інші утиліти, які полегшують роботу з колекціями каміння.

## Діаграма класів предметної області

![image](https://github.com/AnnaSorokina20/Project_PartA_Jewerly/assets/149331565/a9594801-b4b1-4276-990b-546e8bc8200d)



