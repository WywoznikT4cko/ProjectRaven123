using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
    
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed; 
    public int index;







    public void StartDialogue()
    {
        
        
    
            dialogueActive = true;
            index = 0;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        
       
        
        
    }

    private bool dialogueActive = false;
    void Update()
    {
        if (!dialogueActive)
            return;
            
        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

   
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);


        }
    }

    void NextLine()
    {
        if (index<lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueActive = false;
            gameObject.SetActive(false);
        }

    }
}