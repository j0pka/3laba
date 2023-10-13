// Создание кода T4 для модели "D:\учеба\разработка ПМ\BocharovaAutoservice\BocharovaAutoservice\BocharovaModel.edmx" включено. 
// Чтобы включить формирование кода прежних версий, измените значение свойства "Стратегия создания кода" конструктора
// на "Legacy ObjectContext". Это свойство доступно в окне "Свойства", если модель
// открыта в конструкторе.

// Если не сформированы контекст и классы сущности, возможная причина в том, что вы создали пустую модель, но
// еще не выбрали версию Entity Framework для использования. Чтобы сформировать класс контекста и классы сущностей
// для своей модели, откройте модель в конструкторе, щелкните правой кнопкой область конструктора и
// выберите "Обновить модель из базы данных", "Сформировать базу данных из модели" или "Добавить элемент формирования
// кода...".

using System.Data.Entity;

public partial class Bocharova_autoservice : DbContext
{
    private static Bocharova_autoservice _context;

    public object Service { get; internal set; }

    public static Bocharova_autoservice GetContext()
    {
        if (_context == null)   
            _context = new Bocharova_autoservice();
        return _context;
    }
}