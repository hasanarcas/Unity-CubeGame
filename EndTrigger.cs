using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
