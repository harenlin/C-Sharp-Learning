using System;
using System.Collections.Generic;

public class Stack<T> {
    private List<T> elements = new List<T>();

    public void Push(T item) {
        this.elements.Add(item);
    }

    public T Pop() {
        if (elements.Count == 0) {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = this.elements[this.elements.Count - 1];
        this.elements.RemoveAt(this.elements.Count - 1);
        return item;
    }

    public T Peek() {
        if (this.elements.Count == 0) {
            throw new InvalidOperationException("Stack is empty.");
        }

        return this.elements[this.elements.Count - 1];
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
