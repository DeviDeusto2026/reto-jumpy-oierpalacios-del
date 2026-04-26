using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] plataformas;
    private void Start()
    {
        for(int i = 0; i < plataformas.Length; i++)
        {
            if(i != 0)
            {
                plataformas[i].transform.position = new Vector3(Random.Range(-2, 6), plataformas[i - 1].transform.position.y + 3, 0);
            }
            else
            {
                plataformas[i].transform.position = new Vector3(Random.Range(-2, 6), plataformas[i].transform.position.y, 0);
            }
        }
    }
}
