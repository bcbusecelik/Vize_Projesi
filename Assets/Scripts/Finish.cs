using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{


    [SerializeField] private int requiredScore = 30;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    
    private void OnTriggerEnter(Collider other) 
    {
        PlayerManager player = other.GetComponent<PlayerManager>(); 

        if (player.Score >= requiredScore) 
        {
            Debug.Log("Oyun Bitti!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else 
        {
            Debug.Log("Yetersiz puan Gerekli: " + requiredScore + ""); 
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }

   

}
