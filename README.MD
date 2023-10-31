## Домашнее задание к Уроку 7. Рефлексия.

1. Разработайте атрибут, позволяющий методу ObjectToString сохранять поля классов с использованием произвольного имени.

2. Метод StringToObject должен также уметь работать с этим атрибутом для записи значение в свойство по имени его атрибута.

[CustomName(“CustomFieldName”)]
public int I = 0.

Если использовать формат строки с данными использованной нами для предыдущего примера то пара ключ значение для свойства I выглядела бы CustomFieldName:0

---
## Решение:

Для решения задачи был создан класс-атрибут CustomNameFieldAttribute, в котором реализованы свойства: (public string OriginalFieldName { get; set; }) и (public string CustomFieldName { get; set; }). Также реализован контсруктор (CustomNameFieldAttribute(string originalFieldName, string customFieldName)) через атрибуты которого в свойства передаются имена свойств.

В классе Program реализованы следующие методы:

1. ObjectToString(object o) в котором целевому классу(в нашем примере это TestClass) через атрибут CustomNameFieldAttribute задаются поля с произвольным именем.
2. StringToObject(object o) в котором целевому классу(в нашем примере это TestClass) через атрибут CustomNameFieldAttribute записываются значения в свойства с произвольным именем.

В методе (Main(string[] args)) продемонстрирована работа методов  ObjectToString(object o) и StringToObject(object o).
