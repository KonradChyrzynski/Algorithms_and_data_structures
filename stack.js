var http = require('http'); // 1 - Import Node.js core module

var server = http.createServer(function (req, res) {   // 2 - creating server

    //handle incomming requests here..

});

server.listen(5000); //3 - listen for any incoming requests
class Stack 
{
    #height
    #head
    constructor()
    {
        this.#head = null;
        this.#height = 0;
    }

    static node = class
    {
        constructor(data, prev)
        {
            this.data = data;
            this.prev = prev;
        }
    }

    put(data)
    {
        this.#height++;
        this.#head = new Stack.node(data, this.#head);
    }

    pull()
    {
        if(this.#head != null)
        {
            this.#height--;
            this.#head = this.#head.prev;
        }
        else
        {
            return undefined
        }
    }

    peek()
    {
        return this.#head?.data;
    }

    get height()
    {
        return this.#height;
    }
    get wierzch()
    {
        return this.#head
    }
}
function checkSpecialCharacters(
    word,
    open = 
    {
        "(": "circular",
        "[": "rectangular"
    },
    close = 
    {
        ")": "circular",
        "]": "rectangular"
    }
    )
{
    let stack = new Stack()
    for(let char of word)
    {
        if(open[char] != undefined)
        {
            stack.put(open[char]); 
        }
        else if(close[char] != undefined)
        {
            if(stack.peek() === close[char] && stack.peek != undefined)
                stack.pull()
            else
                return false
        }
        else
        {
            return false;
        }

    }
    if(stack.height == 0)
        return true;
    else
        return false;
}

