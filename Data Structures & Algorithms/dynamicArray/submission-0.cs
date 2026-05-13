public class DynamicArray {
    private int capacity;
    private int size = 0;
    private int[] data;

    public DynamicArray(int capacity) {
        this.capacity = capacity;
        data = new int[capacity];
    }

    public int Get(int i) {
        return data[i];
    }

    public void Set(int i, int n) {
        data[i] = n;
    }

    public void PushBack(int n) {
        if (size == capacity) {
            Resize();
        }
        data[size] = n;
        size++;
    }

    public int PopBack() {
        return data[--size];
    }

    private void Resize() {
        this.capacity *= 2;
        var newData = new int[capacity];
        Array.Copy(data, newData, size);
        this.data = newData;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
