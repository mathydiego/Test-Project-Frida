using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer sr;

    [SerializeField] Color color1;
    [SerializeField] Color color2;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.green;
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            if (sr.color == color1) sr.color = color2;
            else sr.color = color1;


            yield return new WaitForSeconds(1);
        }
    }
}
