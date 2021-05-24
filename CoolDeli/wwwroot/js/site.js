// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const getUrl = async (url) => {
    let xhr = new XMLHttpRequest();
    xhr.addEventListener("load", parseResp);
    xhr.open("GET", url);
    xhr.send;
}
const parseResp = (resp) => {
    return JSON.stringify(resp);
}