using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorFlyweight : MonoBehaviour
{
    private Renderer renderer;
    private MaterialPropertyBlock _prop;
    public List<Color> colors;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        _prop = new MaterialPropertyBlock();
    }

    private Color GetRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f));
    }
    private void Start()
    {
        StartCoroutine(update(0.09f));
    }
    IEnumerator update(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            renderer.GetPropertyBlock(_prop);
            _prop.SetColor("_Color", colors[Random.Range(0, colors.Count)]);
            renderer.SetPropertyBlock(_prop);
        }
    }
   
}
