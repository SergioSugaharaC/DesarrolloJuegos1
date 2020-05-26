using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;

public class FirebaseExample: MonoBehaviour {
    void Start() {
        FirebaseDB.init();
        // FirebaseDB.reference.Child("users").Child(user.id).SetRawJsonValueAsync(json);
        FirebaseDB.reference.ChildAdded += HandleChildAdded;
        FirebaseDB.reference.ChildChanged += HandleChildChanged;
        FirebaseDB.reference.ChildRemoved += HandleChildRemoved;
    }
    
    void HandleChildChanged(object sender, ChildChangedEventArgs args){
        if(args.DatabaseError != null){
            Debug.Log(args.DatabaseError.Message);
            return;
        }
        print(args.Snapshot);
    }

    
    void HandleChildRemoved(object sender, ChildChangedEventArgs args){
        if(args.DatabaseError != null){
            Debug.Log(args.DatabaseError.Message);
            return;
        }
        print(args.Snapshot);
    }

    void HandleChildAdded(object sender, ChildChangedEventArgs args){
        if(args.DatabaseError != null){
            Debug.Log(args.DatabaseError.Message);
            return;
        }
        print(args.Snapshot);
    }
}
