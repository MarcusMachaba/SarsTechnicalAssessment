function doThings(data) {
    let x = data.split(',');
    x.sort();
    return x.join(',');
}
