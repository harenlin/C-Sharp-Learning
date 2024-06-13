using System;
using System.Collections.Generic;

public class Queue<T> {
    private List<T> elements = new List<T>();

    public void Enqueue(T item) {
        this.elements.Add(item);
    }

    public T Dequeue() {
        if (this.elements.Count == 0) {
            throw new InvalidOperationException("Queue is empty.");
        }

        T item = this.elements[0];
        this.elements.RemoveAt(0);
        return item;
    }

    public T Peek() {
        if (this.elements.Count == 0) {
            throw new InvalidOperationException("Queue is empty.");
        }

        return this.elements[0];
    }

    public bool IsEmpty() {
        return this.elements.Count == 0;
    }

    public int Count() {
        return this.elements.Count;
    }

	public int Length() {
		return this.elements.Count;
	}
}

