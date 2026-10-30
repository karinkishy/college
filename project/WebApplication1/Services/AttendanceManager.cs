namespace WebApplication1.Services;

public class AttendanceManager
{
    private readonly Dictionary<(int StudentId, DateOnly Date), bool> _records = [];
    public void Add(int studentId, DateOnly date, bool present) => _records[(studentId, date)] = present;
    public void Update(int studentId, DateOnly date, bool present) { if (!_records.ContainsKey((studentId, date))) throw new KeyNotFoundException("Запись посещаемости не найдена."); _records[(studentId, date)] = present; }
    public (int Present, int Absent, double Rate) GetStatistics(int studentId) { var items = _records.Where(x => x.Key.StudentId == studentId).ToArray(); var present = items.Count(x => x.Value); return (present, items.Length - present, items.Length == 0 ? 0 : Math.Round(100d * present / items.Length, 1)); }
    public IReadOnlyList<(int StudentId, DateOnly Date, bool Present)> GetRecords() => _records.Select(x => (x.Key.StudentId, x.Key.Date, x.Value)).OrderByDescending(x => x.Date).ToArray();
}
