using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InteraçõesPlayer : MonoBehaviour
{
    [SerializeField] int countKey = 0;
    [SerializeField] int countCoin = 0;
    [SerializeField] GameObject Coin;
    [SerializeField] GameObject Key;
    TextMeshPro chave;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("House"))
        {
            SceneManager.LoadScene("House");
        }

        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            countCoin++;
        }

        if(other.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene("Fase1");
        }

        if(other.gameObject.CompareTag("key"))
        {
            Destroy(other.gameObject);
            countKey++;
        }
        if (other.gameObject.CompareTag("Dungeon") && countKey == 1)
        {
            SceneManager.LoadScene("castle");
        }
    }
}
