using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool<T> where T : Component
{
    [field: SerializeField] public Transform Parent { private set; get; }
    [field: SerializeField] public T[] Prefabs { private set; get; }
    private Stack<T> pool = new Stack<T>();
    private List<T> activeItems = new List<T>();

    private T GetFromPool()
    {
        T item = pool.Pop();
        activeItems.Add(item);
        InitializeOnGet(item);
        return item;
    }
    public T Get
    {
        get
        {
            if (pool.Count > 0)
                return GetFromPool();

            RefreshActiveItems();

            if (pool.Count > 0)
                return GetFromPool();

            return AddNewItem();
        }
    }
    public T GetActive
    {
        get
        {
            T item = Get;
            item.gameObject.SetActive(true);
            return item;
        }
    }

    private T AddNewItem()
    {
        Random.InitState((int)Time.unscaledTime);
        var item = GameObject.Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], Parent);
        Init(item);
        activeItems.Add(item);
#if UNITY_EDITOR
        item.name = item.name;
#endif
        return item;
    }
    public void DeactiveItems()
    {
        for (int i = 0; i < activeItems.Count; i++)
            if (activeItems[i].gameObject.activeSelf)
            {
                activeItems[i].gameObject.SetActive(false);
                pool.Push(activeItems[i]);
                activeItems.Remove(activeItems[i]);
                i--;
            }
    }

    protected virtual void Init(T item)
    {
    }
    protected virtual void InitializeOnGet(T item)
    {
    }

    private void RefreshActiveItems()
    {
        for (int i = 0; i < activeItems.Count; i++)
            if (!activeItems[i].gameObject.activeSelf)
            {
                pool.Push(activeItems[i]);
                activeItems.Remove(activeItems[i]);
                i--;
            }
    }

    public void SetPrefabs(T[] prefabs) => Prefabs = prefabs;
    public void SetParent(Transform parent) => Parent = parent;
}