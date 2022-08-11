using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boueibutu : MonoBehaviour, IDamage
{
    [SerializeField][Tooltip("耐久値")]
    Slider _tp;
    [SerializeField] int _maxtp;
    [SerializeField] private float Currenttp;

    public void ReceiveDamage(int damage)
    {
        Currenttp -= damage;
        Currenttp = Currenttp - damage;
        _tp.value = (float)Currenttp / (float)_maxtp;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
