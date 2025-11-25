using UnityEngine;
using Yarn.Unity;

public class DialogTrigger : MonoBehaviour
{

    public DialogueRunner dialogueRunner;
    public string startNode;
    public string playerTag = "Player";
    public GameObject pressEHint;

    private bool playerInRange = false;

    public void Start()
    {

        dialogueRunner = GameObject.FindGameObjectWithTag("Dialog").GetComponent<DialogueRunner>();
        //GetComponent<DialogueRunner> GET

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(playerTag)) {
            playerInRange = true;
            if (pressEHint) pressEHint.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag(playerTag)) {
            playerInRange = false;
            if (pressEHint) pressEHint.SetActive(false);
        }
    }

    private void Update() {
        if (!playerInRange) return;
        if (Input.GetKeyDown(KeyCode.E)) {
            if (dialogueRunner != null && !dialogueRunner.IsDialogueRunning) {
                dialogueRunner.StartDialogue(startNode);
            }
        }
    }
}
