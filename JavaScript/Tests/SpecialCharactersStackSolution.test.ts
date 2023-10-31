import { Stack } from '../SpecialCharactersStackSolution';

describe('Stack', () => {
  it('should push and pop correctly', () => {
    const stack = new Stack<number>();

    stack.push(1);
    stack.push(2);
    stack.push(3);

    expect(stack.height).toBe(3);
    expect(stack.peek()).toBe(3);

    stack.pop();
    expect(stack.height).toBe(2);
    expect(stack.peek()).toBe(2);

    stack.pop();
    expect(stack.height).toBe(1);
    expect(stack.peek()).toBe(1);

    stack.pop();
    expect(stack.height).toBe(0);
    expect(stack.peek()).toBeUndefined();
  });

  it('should handle special characters correctly', () => {
    const stack = new Stack<string>();

    expect(stack.checkSpecialCharacters('')).toBe('All blocks closed');
    expect(stack.checkSpecialCharacters('()')).toBe('All blocks closed');
    expect(stack.checkSpecialCharacters('“(«)”')).toBe('All blocks closed');
    expect(stack.checkSpecialCharacters('“(»”')).toBe('Character “ not found');
    expect(stack.checkSpecialCharacters('“(»”)')).toBe('Failed to close block type: doublequoteclose');
  });
});