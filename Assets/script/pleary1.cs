using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;

public class pleary1 : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] float speed;
    [SerializeField] private Slider _jpSlider;
    [SerializeField] int maxjp;
    [SerializeField] private float Currentjp;
    [SerializeField] float timeOut;
    [SerializeField] float Y;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        StartCoroutine(Jpl());
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Currentjp > 100)
        {
            _jpSlider.value = Currentjp / (float)maxjp;
        }
        else
        {
            Currentjp += Time.deltaTime;
            _jpSlider.value = Currentjp / (float)maxjp;
        }
    }

    void Move()
    {
        // 左右のキーの入力を取得
        float x = Input.GetAxis("Horizontal") * speed;
        // 上下のキーの入力を取得
        float z = Input.GetAxis("Vertical") * speed;
        _rb.AddForce(x, 0, z);
        float mousex = Input.GetAxis("Mouse X");
        transform.RotateAround(transform.position, transform.up, mousex);

    }

    private IEnumerator Jpl()
    {
        while (true)
        {
            //i = UnityEngine.Random.Range(0, 10);
            yield return new WaitForSeconds(timeOut);
            Jp();
        }

    }

    void Jp()
    {
        if (Input.GetKey(KeyCode.Space) && Currentjp >= 1)
        {
            Debug.Log("jp");
            Currentjp = Currentjp - 1;
            _jpSlider.value = (float)Currentjp / (float)maxjp;
            _rb.AddForce(0, Y, 0 );
        }
    }
}
