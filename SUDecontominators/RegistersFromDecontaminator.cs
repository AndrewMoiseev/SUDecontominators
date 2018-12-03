namespace SUDecontominators
{
    class RegistersFromDecontaminator
    {
        /// <summary>
        /// Состояние установки:
        /// 0x0001–Термостат ST1 сработал
        /// 0x0002–Термостат ST2 сработал
        /// 0x0004–Перегрев бака 1
        /// 0x0008–Перегрев бака 2
        /// </summary>
        public ushort State { get; set; }
        /// <summary>
        /// Значение датчика температуры 1 в коде АЦП
        /// </summary>
        public ushort TE1ADC { get; set; }
        /// <summary>
        /// Значение датчика температуры 2 в коде АЦП
        /// </summary>
        public ushort TE2ADC { get; set; }
        /// <summary>
        /// Счетчик секунд работы
        /// </summary>
        public ushort Sec { get; set; }
        /// <summary>
        /// Значение датчика температуры 1 в ˚С
        /// </summary>
        public ushort TE1 { get; set; }
        /// <summary>
        /// Значение датчика температуры 2 в ˚С
        /// </summary>
        public ushort TE2 { get; set; }
        /// <summary>
        /// Счетчик ожидания нагрева бака
        /// </summary>
        public ushort Count { get; set; }
        /// <summary>
        /// Адрес ModBus платы управления
        /// </summary>
        public ushort AdrMB { get; set; }
        /// <summary>
        /// Состояние индикатора АВАРИЯ (0-Отк.1-Вкл.)
        /// </summary>
        public ushort HLA { get; set; }
        /// <summary>
        /// Состояние реле 1 (0-Отк.1-Вкл.)
        /// </summary>
        public ushort SK1 { get; set; }
        /// <summary>
        /// Состояние реле 2 (0-Отк.1-Вкл.)
        /// </summary>
        public ushort SK2 { get; set; }
        /// <summary>
        /// Состояние термостата 1 (0-Отк.1-Вкл.)
        /// </summary>
        public ushort ST1 { get; set; }
        /// <summary>
        /// Состояние термостата 2 (0-Отк.1-Вкл.)
        /// </summary>
        public ushort ST2 { get; set; }
        /// <summary>
        /// Состояние индикатора РАБОТА (0-Отк.1-Вкл.)
        /// </summary>
        public ushort HLW { get; set; }
        /// <summary>
        /// Управление реле 1 (0-Отк.1-Вкл.)
        /// </summary>
        public ushort K1 { get; set; }
        /// <summary>
        /// Управление реле 2 (0-ТЭН Aммиак 1-ТЭН Формалин)
        /// </summary>
        public ushort K2 { get; set; }
        /// <summary>
        /// Сброс разрядов состояния State установки 
        /// </summary>
        public ushort RState { get; set; }
        /// <summary>
        /// Уставка температуры перегрева бака ˚С
        /// </summary>
        public ushort UTEhi { get; set; }
        /// <summary>
        /// Уставка температуры нагрева бака
        /// </summary>
        public ushort UTElo { get; set; } //
/// <summary>
/// Уставка времени нагрева бака
/// </summary>
        public ushort Utmin { get; set; } //

    }
}
