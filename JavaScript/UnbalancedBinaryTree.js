class UnbalancedBinaryTree
{
    #head = null;

    static Node = class  {

        constructor(value) {
            this.value = value;
            this.left = null;
            this.right = null;
            this.height = 0;
        }
    }

    add(value) 
    {
        const newNode = new UnbalancedBinaryTree.Node(value);

        if(this.#head === null)
        {
            this.#head = newNode;                    
        }

        let current = this.#head;
    
        while(true)
        {
            if(this.current.value > value)
            {
                if(this.current.left === null)
                {
                    this.current.left = new UnbalancedBinaryTree.Node(value);
                    break;
                }   
                else
                {
                    current = this.current.left;   
                }
            }
            else if(this.current.value < value)
            {
                if(this.current.right === null)
                {
                    this.current.right = new UnbalancedBinaryTree.Node(value);
                    break;
                }
                else
                {
                    current = this.current.right;
                }
            }
        }
    }
}