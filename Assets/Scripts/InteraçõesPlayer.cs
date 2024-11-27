using UnityEngine;
using UnityEngine.SceneManagement;

public class InteraçõesPlayer : MonoBehaviour
{
    [SerializeField] GameObject House;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnColisionEnter(Collision other)
    {
      if(other.gameObject.CompareTag("House") && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(3);

        }
        
    }
}
