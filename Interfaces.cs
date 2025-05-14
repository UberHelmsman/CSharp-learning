﻿namespace GettingStarted;

public interface IBaseCollection
{
    void Add(object obj);
    void Remove(object obj);
}


public class BaseList : IBaseCollection
{
    private object[] items;
    private int count = 0;
    public BaseList(int initialCapacity)
    {
        items = new object[initialCapacity];
    }
    public void Add(object obj)
    {
        items[count] = obj;
        System.Console.WriteLine(obj);
        count++;
    }

    public void Remove(object obj)
    {
        items[count] = null;
        count--;
    }
}

public static class BaseCollectionExt{
    public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects){
        foreach(var item in objects){
            collection.Add(item);
        }
    }
}