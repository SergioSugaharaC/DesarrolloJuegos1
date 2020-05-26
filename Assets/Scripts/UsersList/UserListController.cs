using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;

public class UserListController : MonoBehaviour {
    [SerializeField] GameObject player;
    int iter = 0;

    private void Awake() {
        FirebaseDB.init();
        ViewConsole();
        BeginInstance();
    }

    void ViewConsole() {
        FirebaseDB.instance.GetReference("users").GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
                Debug.LogError("Error With Instance");
            else if (task.IsCompleted) {
                DataSnapshot snap = task.Result;
                foreach (DataSnapshot user in snap.Children) {
                    IDictionary dictUsers = (IDictionary)user.Value;
                    Debug.Log("" + dictUsers["fullname"] + " - " + dictUsers["id"]);
                }
            }
        });
    }

    void BeginInstance() {
        FirebaseDatabase.DefaultInstance.GetReference("users").ValueChanged += HandleValueChanged;    
    }

    void HandleValueChanged(object sender, ValueChangedEventArgs e) {
        if (e.Snapshot != null && e.Snapshot.ChildrenCount > 0) {
            foreach (var childSnapshot in e.Snapshot.Children) {
                Vector3 temp = new Vector3(-2.0f, 4.0f - (1.5f * iter), 0.0f);
                Instantiate(player,temp,Quaternion.identity);
                iter++;
            }
        }
    }
}
