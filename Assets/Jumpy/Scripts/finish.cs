using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    [SerializeField] private GameObject boton;
    private void Start()
    {
        Time.timeScale = 1;
        boton.SetActive(false);
        boton.GetComponent<Button>().onClick.AddListener(()  => Application.Quit());
    }
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
        boton.SetActive(true);
        Debug.Log("Finished");
    }
}
