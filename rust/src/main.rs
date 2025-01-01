use single_linked_list::ListNode;

mod _021_merge_two_lists;
mod single_linked_list;

fn linked_list_to_vector(vector: Vec<i32>) -> Option<ListNode> {
    let mut reversed = vector.iter().rev();
    let init = reversed.next();

    return match init {
        Some(x) => Some(reversed.fold(
            ListNode {
                next: None,
                val: *x,
            },
            |sum, &value| ListNode {
                next: Some(Box::new(sum)),
                val: value,
            },
        )),
        None => None,
    };
}

fn main() {
    let list1 = linked_list_to_vector(vec![1, 2, 4]).unwrap();
    let list2 = linked_list_to_vector(vec!(1, 3, 4));

    let result = _021_merge_two_lists::merge_two_lists(list1, list2);
    println!("ordered list: {}", result);
}
