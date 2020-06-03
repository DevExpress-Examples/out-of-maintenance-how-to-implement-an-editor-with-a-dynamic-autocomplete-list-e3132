
# How to implement an editor with a dynamic autocomplete list

<strong>Starting with version 19.2, LookUpEdit supports the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.LookUpEdit#autosuggest-mode">AutoSuggest Mode<a/>. When a user types in text, the editor fires the AutoSuggest event that runs a custom asynchronous task. This task performs a search against the given data set, and returns the ICollection object with records that match the entered text.</strong>

<strong>For earlier versions:</strong>

<p>This example demonstrates how to create a custom LookUpEdit class descendant that allows you to provide autocomplete items based on typed text. The items can be provided via the GetAutoCompleteList event.</p>

<br/>


