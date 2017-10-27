using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class firebasetestnew : MonoBehaviour
{
    public static firebasetestnew Instance { set; get; }
    public Text MA1Sensor1;
    public Text MA1Sensor2;

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://occult-49a9d.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        FirebaseDatabase.DefaultInstance
            .GetReference("c")
            .ValueChanged += HandleValueChanged;

    }

    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }

        Debug.Log(args.Snapshot.GetRawJsonValue());
        var g1 = FirebaseDatabase
             .DefaultInstance
             .GetReference("c")
             .Child("m1")
             .GetValueAsync();
        //.Result
        MA1Sensor1.text = "Db  " + args.Snapshot.GetRawJsonValue();
        if (g1.IsCompleted)
        {
            
            Debug.Log(MA1Sensor1);
        }
       

    }


    // Update is called once per frame
    void Update()
    {

    }
}
