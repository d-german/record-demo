using System.Text;

namespace RecordDemo;

public class Foo
{
    public int Bar { get; set; }
}

public class Foo1 : IEquatable<Foo1>
{
    public int Bar1 { get; init; }

    protected virtual Type EqualityContract
    {
        get { return typeof(Foo1); }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Foo1");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(" ");
        }

        stringBuilder.Append("}");
        return stringBuilder.ToString();
    }

    protected virtual bool PrintMembers(StringBuilder builder)
    {
        builder.Append("Bar");
        builder.Append(" = ");
        builder.Append(Bar1);
        return true;
    }

    public static bool operator !=(Foo1 left, Foo1? right)
    {
        return !(left == right);
    }

    public static bool operator ==(Foo1 left, Foo1? right)
    {
        if ((Foo1)left != right)
        {
            return left.Equals(right);
        }

        return true;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Foo1);
    }

    public virtual bool Equals(Foo1? other)
    {
        if ((object)this != other)
        {
            if ((object)other! != null && EqualityContract == other.EqualityContract)
            {
                return EqualityComparer<int>.Default.Equals(Bar1, other.Bar1);
            }

            return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Bar1);
    }
}
