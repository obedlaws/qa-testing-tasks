// Setting varibles
const id = pm.environment.get('twt_id');


//Tests
pm.test("Status code should be 200", ()=>{
    pm.response.to.have.status(200);
})

pm.test("Should include tweet id", ()=>{
    const response = pm.response.json();
    const twt = response.data.id;
    pm.expect(twt).to.eql(id);
})

pm.test("Should include tweet text", ()=>{
    pm.expect(pm.response.text()).to.include('text');
})
