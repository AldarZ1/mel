using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int myInt;

    [SerializeField]
    private float myFloat;

    [SerializeField]
    private string myString;

    [Header("Настройки игрока")]
    public int health;
    public float speed;

    [Range(1, 100)]
    public int damage;

    [HideInInspector]
    public int internalValue;

    void Start()
    {
        Debug.Log("Значение myInt: " + myInt);
        Debug.Log("Значение myFloat: " + myFloat);
        Debug.Log("Значение myString: " + myString);
    }
}
