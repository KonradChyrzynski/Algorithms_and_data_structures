interface Node<T> {
    data: T;
    prev: Node<T> | null;
}

class Stack<T> {
    #height: number;
    #head: Node<T> | null;

    constructor() {
        this.#head = null;
        this.#height = 0;
    }

    static Node = class<T> {
        data: T;
        prev: Node<T> | null;

        constructor(data: T, prev: Node<T> | null) {
            this.data = data;
            this.prev = prev;
        }
    };

    push(data: T): void {
        this.#height++;
        this.#head = new Stack.Node(data, this.#head);
    }

    pop(): void {
        if (this.#head !== null) {
            this.#height--;
            this.#head = this.#head.prev;
        }
    }

    peek(): T | undefined {
        return this.#head?.data;
    }

    get height(): number {
        return this.#height;
    }

    get top(): Node<T> | null {
        return this.#head;
    }

    public checkSpecialCharacters(
        word: string,
        open: Record<string, string> = {
            "(": "leftparenthesis",
            "“": "doublequoteopen",
            "»": "doublequoteclose",
        },
        close: Record<string, string> = {
            ")": "rightparenthesis",
            "”": "doublequoteclose",
            "«": "doublequoteopen",
        }
    ): string {
        const stack = new Stack<string>();
        for (const char of word) {
            if (open[char] !== undefined) {
                stack.push(open[char]);
            } else if (close[char] !== undefined) {
                if (stack.peek() === close[char]) stack.pop();
            } else {
                return "Character " + char + " not found";
            }
        }

        if (stack.height === 0) return "All blocks closed";
        let failureMessage = "";
        while (stack.height !== 0) {
            failureMessage += " Failed to close block type: " + stack.peek();
            stack.pop();
        }

    return failureMessage;
}
}


export { Stack };