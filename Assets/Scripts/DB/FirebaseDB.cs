using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class FirebaseDB {
    private static string URL = "https://desjuegos1-test.firebaseio.com/";
    public static DatabaseReference reference;
    public static FirebaseDatabase instance;
    public static void init(){
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl(URL);
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        instance = FirebaseDatabase.DefaultInstance;
    }
}
