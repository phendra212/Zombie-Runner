using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load_Splash : MonoBehaviour
{

    public Transform masukLoadingBar;

    public string SceneName;

    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;

    // Start is called before the first frame update
    void Update()
    {
        if (nilaiSekarang < 100) {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiSekarang);
        }
        else
        {
            Application.LoadLevel(SceneName);
        }
        masukLoadingBar.GetComponent<Image>().fillAmount = nilaiSekarang / 100;
    }
}
