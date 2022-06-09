//Tests
pm.test("Status code should be 200", ()=>{
    pm.response.to.have.status(200);
})

pm.test("Should include User ID", ()=>{
    pm.expect(pm.response.text()).to.include('id');
})

pm.test("Should include name", ()=>{
    pm.expect(pm.response.text()).to.include('name');
})

pm.test("Should include username", ()=>{
    pm.expect(pm.response.text()).to.include('username');
})