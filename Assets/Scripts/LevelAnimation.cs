using UnityEngine;
using UnityEngine.Events;

public class LevelAnimation : MonoBehaviour
{  
     [SerializeField]
     private string readySoundname = "ready";
     [SerializeField]
     private string goSoundName = "go";
     [SerializeField]
     private string levelAnimationName = "LevelAnimation";
     [SerializeField]
     private UnityEvent onStartGame;
     [SerializeField]
     private Animator animator;
     private void Start()
    {
        animator.Play(levelAnimationName, 0, 0f);
    }
    public void ReadyEvent()
    {
        SoundManager.instance.Play(readySoundname);
    }

    public void GoEvent()
    {
        SoundManager.instance.Play(goSoundName);
    }

    public void StartGame()
    {
        onStartGame?.Invoke();
    }
}
