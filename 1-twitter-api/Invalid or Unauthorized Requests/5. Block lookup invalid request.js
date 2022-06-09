//Tests
pm.test("Status code should be 400", ()=>{
    pm.response.to.have.status(400);
})

pm.test("Title should say 'Invalid Request'", ()=>{
    const response = pm.response.json();
    const title = response.title;
    pm.expect(pm.response.text()).to.include(title);
})

pm.test("Should confirm one or more parameters are invalid", ()=>{
    const response = pm.response.json();
    const detail = response.detail
    pm.expect(pm.response.text()).to.include(detail);
})