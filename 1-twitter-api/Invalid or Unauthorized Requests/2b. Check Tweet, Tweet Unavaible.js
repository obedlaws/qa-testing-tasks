

pm.test("Status code should be 200", ()=>{
    pm.response.to.have.status(200);
})

pm.test("Title should indicate 'Not Found Error'", ()=>{
    const response = pm.response.json();
    const title = response.errors[0].title
    pm.expect(pm.response.text()).to.include(title)
})