namespace FluentNHibernate.Conventions.Alterations
{
    public interface IManyToOneAlteration : IAlteration
    {
        void ColumnName(string columnName);
    }
}