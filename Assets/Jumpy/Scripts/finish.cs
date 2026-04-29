using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    [SerializeField] private GameObject texto;
    private void Start()
    {
        texto.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        texto.SetActive(true);
    }
}
