namespace MyOwnList;

public class MyOwnList<T>
{
    private T[] _array;

    public int Count => _array.Length;

    public MyOwnList()
    {
        _array = new T[0];
    }

    public T this[int index] => _array[index];
    
    public void Add(T data)
    {
        var newArray = new T[_array.Length + 1];

        for (int i = 0; i < Count; i++)
        {
            if(_array[0] == null) break;
            
            newArray[i] = _array[i];
        }
        
        _array = newArray;

        for (int i = 0; i < Count; i++)
        {
            if (i >= Count - 1)
                _array[i] = data;
        }
    }

    public void Remove(int index)
    {
        var newArray = new T[_array.Length - 1];
        var continued = false;  
        
        for (int i = 0; i < Count; i++)
        {
            if(_array[0] == null) break;

            if (i == index)
            {
                continued = true;
                continue;
            }

            if (continued)
            {
                newArray[i - 1] = _array[i];
                continue;
            }
            
            newArray[i] = _array[i];
        }

        _array = newArray;
    }

    public void Clear()
    {
        T[] emptyArray = new T[0];
        _array = emptyArray;
    }

    public bool Contains(T exampleData)
    {
        foreach (var data in _array)
        {
            if (data.Equals(exampleData))
                return true;
        }
        
        return false;
    }
}