using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //for script reference
    private SCRIPT_TestSource testSource;
    //for object reference
    private Transform sourceTransform;

    void Start()
    {
        GameObject sourceObject = GameObject.Find("TestSource");
        //for script reference
        if (sourceObject != null)
        {
            testSource = sourceObject.GetComponent<SCRIPT_TestSource>();
            Debug.Log("Retrieved testNumber: " + testSource.testNumber);
        }
        else
        {
            Debug.LogError("No GameObject with the 'TestSource' tag found!");
        }
        //for object reference
        if (sourceObject != null)
        {
            // Get the Transform component of the object
            sourceTransform = sourceObject.transform;

            // Retrieve and log the scale
            Vector3 objectScale = sourceTransform.localScale;
            Debug.Log("TestSource scale: " + objectScale);
        }
        else
        {
            Debug.LogError("GameObject 'TestSource' not found in the scene!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
