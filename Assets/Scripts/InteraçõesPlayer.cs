using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
using TMPro;

public class InteraçõesPlayer : MonoBehaviour
{
    [SerializeField] int countKey = 0;
    [SerializeField] int countCoin = 0;
    [SerializeField] GameObject Coin;
    [SerializeField] GameObject Key;
    TextMeshPro chave;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
=======

public class InteraçõesPlayer : MonoBehaviour
{
    [SerializeField] GameObject House;
   
>>>>>>> 65cc080203e4027163bb02d0726edb69827efc72
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
<<<<<<< HEAD
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
=======
    private void OnColisionEnter(Collision other)
    {
      if(other.gameObject.CompareTag("House") && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(3);

        }
        
>>>>>>> 65cc080203e4027163bb02d0726edb69827efc72
    }
}
