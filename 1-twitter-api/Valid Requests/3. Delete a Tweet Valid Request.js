//Setting variables
const result = true

//Tests
pm.test("Status code should be 200", ()=>{
    pm.response.to.have.status(200);
})

pm.test("Should confirm that tweet is deleted", ()=>{
    const response = pm.response.json();
    const del = response.data.deleted;
    pm.expect(result).to.eql(del);
})