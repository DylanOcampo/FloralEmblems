using UnityEngine;

public class Drag : MonoBehaviour {
  
  public bool isDragging;

  // Update is called once per frame
  void Update() {
    if(isDragging){
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position;
        transform.Translate(mousePosition);
    }
  }

  private void OnMouseDown() {
    isDragging = true;
  }

  private void OnMouseUp() {
    isDragging = false;
  }


}