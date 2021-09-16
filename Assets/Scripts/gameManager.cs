using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public Text time;
    public float currentTime;
    public static gameManager I;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0, 0.5f);
        init();
    }

    void init()
    {
        time.text = "0.00";
        currentTime = 0.0f;
    }

    private void Awake()
    {
        I = this;
    }

    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        time.text = currentTime.ToString("N2");
    }
}
